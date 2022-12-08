// Create Bitmap object
using System.Drawing;

Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

// Create and initialize Graphics
Graphics graphics = Graphics.FromImage(bitmap);
// Create Pen
Pen pen = new Pen(Color.FromKnownColor(KnownColor.Blue), 2);
// Draw arc
graphics.DrawArc(pen, 0, 0, 700, 700, 0, 180);
// Create another Pen
Pen pen1 = new Pen(Color.FromKnownColor(KnownColor.Red), 2);
// Draw ellipse
graphics.DrawEllipse(pen1, 10, 10, 900, 700);
// Save the drawing into desired image format
bitmap.Save(@"C:\Users\coditas\Desktop\drawing.png");