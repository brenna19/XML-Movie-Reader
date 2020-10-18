using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //For XML reading and writing

namespace XML_Movie_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlTextReader readXML = new XmlTextReader("movies.xml"); //Declare a textreader

        public void readFile()
        {
            Movie movie = new Movie();
            readXML.ReadToFollowing("movie");
            readXML.MoveToFirstAttribute();
            Console.WriteLine("Genre: " + readXML.Value);

            //Place the xmlReader at the 'title' tag of the current 'book' node
            readXML.ReadToFollowing("title");                       
            Console.WriteLine("Title: " + readXML.ReadElementContentAsString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readFile();
        }
    }
}
