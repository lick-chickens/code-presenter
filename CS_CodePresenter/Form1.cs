using System.Runtime.Serialization.Formatters.Binary;
using Utilities;

namespace CS_CodePresenter
{
    public partial class Form1 : Form
    {
        // Global hotkey setup
        globalKeyboardHook gkh = new globalKeyboardHook();
        Dictionary<string, Keys> hotkeyPair = new Dictionary<string, Keys>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hotkeyPair.Add("Rec", Keys.F1);
            hotkeyPair.Add("Play", Keys.F2);
            gkh.HookedKeys.Add(hotkeyPair["Rec"]);
            gkh.HookedKeys.Add(hotkeyPair["Play"]);
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        }

        // Global hotkey events

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            // Use clipboard as cache to get selected text
            var clipboard_cache = Clipboard.GetText() == null ? "" : Clipboard.GetText();  // Store current data
            if (e.KeyCode == hotkeyPair["Rec"])
            {
                // Record
                SendKeys.Send(cb_delete.Checked ? "^x" : "^c");
                int selection_cache = lb_actionList.SelectedIndex + 1;
                lb_actionList.Items.Insert(selection_cache, Clipboard.GetText());
                lb_actionList.SelectedIndex = selection_cache;
            } else if (e.KeyCode == hotkeyPair["Play"] && lb_actionList.SelectedIndex != -1)
            {
                // Playback
                Clipboard.SetText(lb_actionList.SelectedItem.ToString());
                SendKeys.Send("^v");
                lb_actionList.SelectedIndex = lb_actionList.SelectedIndex == lb_actionList.Items.Count - 1 ? 0 : lb_actionList.SelectedIndex + 1;
            }
            Clipboard.SetText(clipboard_cache);  // Restore to previous data
            e.Handled = true;  // Cancel default action
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;  // Cancel default action
        }

        // Detect hotkeys

        private void tb_hotkeyRec_KeyDown(object sender, KeyEventArgs e)
        {
            gkh.HookedKeys.Remove(hotkeyPair["Rec"]);
            hotkeyPair["Rec"] = e.KeyCode;
            gkh.HookedKeys.Add(hotkeyPair["Rec"]);
            lb_actionList.Focus();
            ((TextBox)sender).Text = e.KeyCode.ToString();
        }

        private void tb_hotkeyPlay_KeyDown(object sender, KeyEventArgs e)
        {
            gkh.HookedKeys.Remove(hotkeyPair["Play"]);
            hotkeyPair["Play"] = e.KeyCode;
            gkh.HookedKeys.Add(hotkeyPair["Play"]);
            lb_actionList.Focus();
            ((TextBox)sender).Text = e.KeyCode.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lb_actionList.SelectedIndex != -1) { 
                lb_actionList.Items.RemoveAt(lb_actionList.SelectedIndex);
                lb_actionList.SelectedIndex = lb_actionList.Items.Count == 0 ? -1 : 0;
            }
        }

        private void cb_topmost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cb_topmost.Checked;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            List<string> actions = lb_actionList.Items.Cast<string>().ToList();
            Serialize(actions, System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), tb_projectName.Text + ".ACTIONS"));
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "action files|*.ACTIONS";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            foreach (string i in (List<string>) Deserialize(filePath))
            {
                lb_actionList.Items.Add(i);
            }
        }

        // Serialization methods

        public static void Serialize(object value, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                formatter.Serialize(fStream, value);
            }
        }

        public static object Deserialize(string path)
        {
            if (System.IO.File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream fStream = File.OpenRead(path))
                {
                    return formatter.Deserialize(fStream);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                }
            } else
            {
                return new List<string>();
            }
        }
    }
}