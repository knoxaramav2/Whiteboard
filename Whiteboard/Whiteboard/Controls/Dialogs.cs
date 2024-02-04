using System.Diagnostics;

namespace Whiteboard.Controls
{
    internal class Prompts
    {
        public static string NewNodeDialog(string text, string caption)
        {
            var prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
            };

            var prmptLabel = new Label() { Left = 25, Top = 20, Text = text, Width = 250 };
            var input = new TextBox() { Left = 25, Top = 50, Width = 250 };

            var cancel = new Button() { Text = "Cancel", Left = 25, Width = 80, Top = 75 };
            var confirm = new Button() { Text="OK", Left=195, Width=80, Top=75, DialogResult = DialogResult.OK };

            cancel.Click += (sender, e) => { prompt.Close(); };
            confirm.Click += (sender, e) => { prompt.Close(); Debug.WriteLine("ACCEPT"); };

            prompt.Controls.Add(prmptLabel);
            prompt.Controls.Add(input);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(confirm);
            prompt.AcceptButton = confirm;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? input.Text : "";
        }
    }
}
