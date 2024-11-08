using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace q3
{
    public partial class Form1 : Form
    {
        private static readonly HashSet<string> Actions = new HashSet<string>
        {
            "Start", "Stop", "Accelerate", "Brake", "Right"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Compile_Click(object sender, EventArgs e)
        {
            string input = Input.Text;
            string[] commands = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool result = ParseCommands(commands);
            Output.Text = result ? "Valid command sequence!" : "Invalid command sequence.";
        }

        private bool ParseCommands(string[] commands)
        {
            Stack<string> stack = new Stack<string>();

            foreach (string command in commands)
            {
                if (Actions.Contains(command))
                {
                    stack.Push("Action");
                }
                else if (command.Equals("Right", StringComparison.OrdinalIgnoreCase))
                {
                    stack.Push("Turn");
                }
                else
                {
                    return false; // Invalid command
                }

                // Bottom-Up Parsing
                while (stack.Count >= 1)
                {
                    if (stack.Peek() == "Action")
                    {
                        stack.Pop();
                        if (stack.Count >= 1 && stack.Peek() == "Action")
                        {
                            stack.Pop();
                            stack.Push("CMD");
                        }
                        else
                        {
                            stack.Push("CMD");
                        }
                    }
                    else if (stack.Peek() == "Turn")
                    {
                        stack.Pop();
                        stack.Push("Action");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return stack.Count == 1 && stack.Peek() == "CMD";
        }
    }
}

