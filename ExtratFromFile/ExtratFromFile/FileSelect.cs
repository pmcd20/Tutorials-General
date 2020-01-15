using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtratFromFile
{
    public partial class FileSelect : Form
    {
        public FileSelect()
        {
            InitializeComponent();
        }

        private void FileSelect_Load(object sender, EventArgs e)
        {
            txtFile.Text = "C:/Paul Mc Donagh/Temp/RsAccountsPervasiveSchema.sql";

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string[] MyFileLines = System.IO.File.ReadAllLines(txtFile.Text);
            string[] xxx  = MyFileLines.Where(s => s.ToUpper().Contains("CREATE UNIQUE INDEX") 
            || s.ToUpper().Contains("CREATE INDEX")).ToArray();

            string[] xxd = xxx.Select(s => s.Replace("\"", string.Empty)).ToArray();


            for (int lineNumber = 0; lineNumber < xxd.Length; lineNumber++)
            {
                string[] splitLine = xxd[lineNumber].ToUpper().Split(' ');

                int pos = Array.IndexOf(splitLine, "INDEX");

                if (pos == 0) {  continue;}

                //name of table resides in the 3rd string from the word index
                string fullNameWithBracket = splitLine[pos + 3];

                string part = fullNameWithBracket.Substring(0, fullNameWithBracket.IndexOf('('));

                if (part.Length < fullNameWithBracket.Length)
                {
                    splitLine[pos + 1] = part + "_" + splitLine[pos + 1];
                }

                //put array back to string

                string newLine = string.Join(" ",splitLine);

                // replace new line with old line position

                xxd[lineNumber] = newLine;



            }



            System.IO.File.WriteAllLines(@"C:\Paul Mc Donagh\Temp\WriteLines.txt", xxd);


        }
    }
}
