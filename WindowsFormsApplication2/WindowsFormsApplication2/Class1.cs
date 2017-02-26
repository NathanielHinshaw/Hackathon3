using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2;
using System.Windows.Forms;
namespace DraggableControls
{

    public static class ControlExtension
    {
        // TKey is control to drag, TValue is a flag used while dragging
        private static Dictionary<Control, bool> draggables =
                   new Dictionary<Control, bool>();
        static int Flag = 0;
        static int CurX = 0;
        private static System.Drawing.Size mouseOffset;
           
        /// <summary>
        /// Enabling/disabling dragging for control
        /// </summary>
        public static void Draggable(this Control control, bool Enable)
        {
            if (Enable)
            {
                // enable drag feature
                if (draggables.ContainsKey(control))
                {   // return if control is already draggable
                    return;
                }
                // 'false' - initial state is 'not dragging'
                draggables.Add(control, false);

                // assign required event handlersnnn
                control.MouseDown += new System.Windows.Forms.MouseEventHandler(control_MouseDown);
                control.MouseUp += new System.Windows.Forms.MouseEventHandler(control_MouseUp);
                control.MouseMove += new System.Windows.Forms.MouseEventHandler(control_MouseMove);
            }
            else
            {
                // disable drag feature
                if (!draggables.ContainsKey(control))
                {  // return if control is not draggable
                    return;
                }
                // remove event handlers
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                draggables.Remove(control);
            }
        }
        static void control_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new System.Drawing.Size(e.Location);
            // turning on dragging
            draggables[(Control)sender] = true;
            Class2.MyGlobalList.Remove(((Control)sender).Right);

            CurX = ((Control)sender).Left;
          
            //  if(((Control)sender).Top != Class2.LineY - 41)
            //  {
            //      Flag = 0;
            //  }
        }
        static void control_MouseUp(object sender, MouseEventArgs e)
        {




           //if (Math.Abs(((Control)sender).Top-20) == 0)
           // {

           // }
            // turning off dragging

           // if (!((Control)sender).Tag.ToString().Contains("asdf"))
            //{
              //  if ((string)((PictureBox)((Control)sender)).Tag == "Ifelse2")
               // {
                //    ((PictureBox)((Control)sender)).Image = global::WindowsFormsApplication2.Properties.Resources.ifelse;
                 //   ((PictureBox)((Control)sender)).Top = ((PictureBox)((Control)sender)).Top + 155;
                 //   ((PictureBox)((Control)sender)).Height = ((PictureBox)((Control)sender)).Height - 100;

              //  }

                for (int i = Form1.ActiveForm.Controls.Count - 1; i >= 0; i--)
                {
                    if ((string)Form.ActiveForm.Controls[i].Tag == "Text" + CurX)
                    {
                        ((TextBox)(Form.ActiveForm.Controls[i])).Left = ((PictureBox)((Control)sender)).Left;
                    ((TextBox)(Form.ActiveForm.Controls[i])).Tag = "Text" + ((PictureBox)((Control)sender)).Left;
                    ((TextBox)(Form.ActiveForm.Controls[i])).Top = ((PictureBox)((Control)sender)).Top + 125;


                }
                    {
                       // Form1.ActiveForm.Controls.RemoveAt(i);
                    }
                }


             //   if ((string)((PictureBox)((Control)sender)).Tag == "Ifelse2")
              //  {
              //      ((PictureBox)((Control)sender)).Tag = "Ifelse";
              //  }
          //  }
            if (Math.Abs(((Control)sender).Top + 41 - Class2.LineY) < 75)
            {
                ((Control)sender).Top = Class2.LineY - 41;

                TextBox namelabel = new TextBox();
                Flag = 0;
                for (int i = Form1.ActiveForm.Controls.Count - 1; i >= 0; i--)
                {
                    for(int f = CurX-125; f < CurX + 125; f++)
                    {
                        if (((string)Form.ActiveForm.Controls[i].Tag == "Text" + f))
                        {
                            Flag = 1;
                        }
                    }


                }


                if (Flag == 0)
                {
                    if (((PictureBox)((Control)sender)).Tag != "End" && ((PictureBox)((Control)sender)).Tag != "Else")
                    {
                        namelabel.Location = new Point(((Control)sender).Left, ((Control)sender).Top + 125);
                        namelabel.AutoSize = true;
                        namelabel.Text = "asdf";
                        namelabel.Tag = "Text" + ((Control)sender).Left;
                        Form1.ActiveForm.Controls.Add((Control)(namelabel));
                        namelabel.BringToFront();
                        Flag = 1;
                    }
                   
                    else
                    {
                        namelabel.Location = new Point(((Control)sender).Left, ((Control)sender).Top + 125);
                        namelabel.AutoSize = true;
                        namelabel.Text = "End Condition";
                        namelabel.Tag = "Text" + ((Control)sender).Left;
                        Form1.ActiveForm.Controls.Add((Control)(namelabel));
                        namelabel.BringToFront();
                        namelabel.Visible = false;
                        Flag = 1;
                    }
                }



                Class2.MyGlobalList.Add(((Control)sender).Right);

            

                   if ((string)((PictureBox)((Control)sender)).Tag == "Ifelse") { 
                   //((PictureBox)((Control)sender)).Image = global::WindowsFormsApplication2.Properties.Resources.ifelselines;
                    //((PictureBox)((Control)sender)).Tag = "Ifelse2";
                    ((Control)sender).Top = Class2.LineY - 35;
                 }



   



            }


            if (!((string)((PictureBox)((Control)sender)).Tag == "Ifelse"))
               // if (!((string)((PictureBox)((Control)sender)).Tag == "Ifelse2"))
              //  {
                    {
                        if (Math.Abs(((Control)sender).Top + 41 - Class2.TopLineY) < 75)
                        {
                            ((Control)sender).Top = Class2.TopLineY - 41;
                        }

                        if (Math.Abs(((Control)sender).Top + 41 - Class2.BottomLineY) < 75)
                        {
                            ((Control)sender).Top = Class2.BottomLineY - 41;
                        }
             //       }
                }
            draggables[(Control)sender] = false;
            
        }
        static void control_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (draggables[(Control)sender] == true)
            {
                // calculations of control's new position
                System.Drawing.Point newLocationOffset = e.Location - mouseOffset;

              //  if (!((Control)sender).Tag.ToString().Contains("asdf"))
             //   {


                    ((Control)sender).Left += newLocationOffset.X;


                    if ((string)((PictureBox)((Control)sender)).Tag == "Ifelse2")
                    {
                        ((Control)sender).Top += newLocationOffset.Y - 35;
                    }
                    else
                    {
                        ((Control)sender).Top += newLocationOffset.Y;
                    }
               // }
              //  if (Flag == 1)
                //{
                    
                   
                   // Flag = 0;
                //}
            }
          
        }
    }
}