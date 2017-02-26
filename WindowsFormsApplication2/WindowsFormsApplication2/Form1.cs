using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DraggableControls;
using System.Collections;

namespace WindowsFormsApplication2
{





    public partial class Form1 : Form
    {
        int flag = 0;
        int TabFlag = 0;
        int count = 0;
        int f = 0;
        int g = 0;

        String s;
        System.Threading.Thread t;

        //      int Linex = 0;
        //      int Liney = 0;


        public Form1()
        {
            InitializeComponent();
            Class2.LineX = this.label1.Location.X;
            Class2.LineY = this.label1.Location.Y;

           // Class2.TopLineX = this.label2.Location.X;
           // Class2.TopLineY = this.label2.Location.Y;

           // Class2.BottomLineX = this.label3.Location.X;
           // Class2.BottomLineY = this.label3.Location.Y;

           // this.pictureBox9.Width = 1000;

            textBox1.Text = "Outputs";
            label1.Text = "";
            //this.pictureBox9.Image = global::WindowsFormsApplication2.Properties.Resources.line1;
            //panel1.HorizontalScroll.Enabled = true;
            //this.AutoScroll = true;
            //HScrollBar hScroller = new HScrollBar();
            //this.Controls.Add(hScroller);

        }


       
      





        private void button1_MouseDown(object sender, EventArgs e)
        {
        

   

        }




        private void namelabel_DragDrop(object sender, EventArgs e)
        {
            var Label = (PictureBox)sender;

          //  Label.Text = "fdas";
            flag = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {                                                           //IfThen
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            //namelabel.Text = "asdf";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Tag = "IfThen";
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.ifthen;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {                                                           //IfElse
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            //namelabel.Text = "asdf";
            namelabel.AutoSize = true;
            namelabel.Tag = "Else";
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources._else;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)      //While
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "While";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources._while;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)      //For
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "For";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.For;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)      //Int
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "Int";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources._int;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox7_Click(object sender, EventArgs e)      //Float
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "Float";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources._float;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox8_Click(object sender, EventArgs e)      //String
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "String";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources._string;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox namelabel = new PictureBox();            //End
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "End";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.end;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {                                                           //Random
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "Random";
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.random;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "Print";
            namelabel.AutoSize = true;                      //Print
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.print;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PictureBox namelabel = new PictureBox();
            namelabel.Location = new Point(1659, 36);
            namelabel.Tag = "Edit";                               //Edit
            namelabel.AutoSize = true;
            // namelabel.DragDrop += new DragEventHandler(namelabel_DragDrop);
            namelabel.Draggable(true);
            namelabel.Image = global::WindowsFormsApplication2.Properties.Resources.edit;
            this.Controls.Add(namelabel);
            namelabel.BringToFront();
        }





        private void timer1_Tick(object sender, EventArgs e)
        {




            g = 0;
           for(int i = 0; i < Class2.MyGlobalList.Count;i++)
            {
                //object o = Class2.MyGlobalList[i];
                
                //f = (int)(o);
                int f = (int)Class2.MyGlobalList[i];
              //  
                if (f > g)

                {
                    g = f;

                   
                    //System.Diagnostics.Debug.WriteLine(Class2.MyGlobalList[i]);
                }
                

                // System.Diagnostics.Debug.WriteLine(i);
            }
          //  System.Diagnostics.Debug.WriteLine(g);
            pictureBox9.Width = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<PictureBox> FormList = new List<PictureBox>();
            List<String> StringList = new List<String>();
            for (int i = Form1.ActiveForm.Controls.Count - 1; i >= 0; i--)
                {
                if (Form1.ActiveForm.Controls[i].Location.Y == 309)
                {
                    if (Form1.ActiveForm.Controls[i].GetType().ToString().Contains("Picture"))
                    {
                        {
                            FormList.Add((PictureBox)((Form1.ActiveForm.Controls[i])));
                           // System.Diagnostics.Debug.WriteLine(FormList[i].GetType());
                        }

                    }
                   
                }
                //System.Diagnostics.Debug.WriteLine(Class2.LineY);
              //  System.Diagnostics.Debug.WriteLine(Form1.ActiveForm.Controls[i].Location.Y);

            }
            FormList = FormList.OrderBy(a => a.Location.X).ToList();
            StringList.Add("import random");
            StringList.Add("");
            for (int p = 0; p < FormList.Count; p++)
            {
              
                for (int i = Form1.ActiveForm.Controls.Count - 1; i >= 0; i--)
                {
                    if (((string)Form.ActiveForm.Controls[i].Tag == "Text" + FormList[p].Location.X))
                    {
                        if (!(Form.ActiveForm.Controls[i].Text.ToString().Contains("asdf")))
                        {
                            System.Diagnostics.Debug.WriteLine(FormList[p].Tag);
                            System.Diagnostics.Debug.WriteLine((((string)Form.ActiveForm.Controls[i].Text)));
                            
                            if(FormList[p].Tag == "Int")
                            {

                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                // StringList.Add("int " + ((string)Form.ActiveForm.Controls[i].Text) + ";");
                                s = (((string)Form.ActiveForm.Controls[i].Text));
                                StringList.Add(s);
                                s = "";
                            }


                            if (FormList[p].Tag == "Edit")
                            {

                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                // StringList.Add("int " + ((string)Form.ActiveForm.Controls[i].Text) + ";");
                                s = (((string)Form.ActiveForm.Controls[i].Text));
                                StringList.Add(s);
                                s = "";
                            }


                            if (FormList[p].Tag == "Float")
                            {

                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                // StringList.Add("int " + ((string)Form.ActiveForm.Controls[i].Text) + ";");
                                s +=(((string)Form.ActiveForm.Controls[i].Text));
                                StringList.Add(s);
                                s = "";
                            }


                            if (FormList[p].Tag == "String")
                            {

                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                // StringList.Add("int " + ((string)Form.ActiveForm.Controls[i].Text) + ";");
                                s+=(((string)Form.ActiveForm.Controls[i].Text));
                                StringList.Add(s);
                                s = "";
                            }


                            if (FormList[p].Tag == "IfThen")
                            {
                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                s+= ("if " + ((string)Form.ActiveForm.Controls[i].Text) + ":");
                                StringList.Add(s);
                                TabFlag += 1;
                                s = "";
                                //StringList.Add("{");
                            }



                            if (FormList[p].Tag == "Random")
                            {
                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                s += (((string)Form.ActiveForm.Controls[i].Text) + "= random.randint(0, 100)");
                                StringList.Add(s);
                                //TabFlag += 1;
                                s = "";
                                //StringList.Add("{");
                            }

                            if (FormList[p].Tag == "Else")
                            {

                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                // StringList.Add("int " + ((string)Form.ActiveForm.Controls[i].Text) + ";");
                                s += ("else:");
                                TabFlag += 1;
                                StringList.Add(s);
                                s = "";
                            }



                            if (FormList[p].Tag == "While")
                            {
                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }
                                s += ("while " + ((string)Form.ActiveForm.Controls[i].Text) + ":");
                                StringList.Add(s);
                                TabFlag += 1;
                                s = "";
                                //StringList.Add("{");
                            }



                            if (FormList[p].Tag == "Print")
                            {
                                for (int q = 0; q < TabFlag; q++)
                                {
                                    s += "   ";
                                }


                                s+=("print("+((string)Form.ActiveForm.Controls[i].Text)+ ")");
                                StringList.Add(s);
                                //StringList.Add("printf(\"%d\"," + ((string)Form.ActiveForm.Controls[i].Text) + ");");
                                s = "";
                            }


                            if (FormList[p].Tag == "End")
                            {
                                TabFlag -= 1;
                            }
                            System.IO.File.WriteAllLines(@"C:\BlockGen\Output.Py", StringList);


                        }
                        // for (int q = 0; q < StringList.Count; p++)
                        // {
                        //   System.Diagnostics.Debug.WriteLine(StringList[q]);
                        // }
                    }
                    }
                }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
