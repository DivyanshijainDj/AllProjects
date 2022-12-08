using System.Drawing;

Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
Graphics graphics = Graphics.FromImage(bitmap);


Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
graphics.DrawArc(pen, 0, 0, 700, 700, 0, 180);



Pen pen1 = new Pen(Color.FromKnownColor(KnownColor.Red), 2);
graphics.DrawRectangle(pen1, 10, 10, 900, 700);



bitmap.Save(@"C:\Users\coditas\Desktop\drawing.png");

Console.WriteLine("Sucessfully Created the Image !!");