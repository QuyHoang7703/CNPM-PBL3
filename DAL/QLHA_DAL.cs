using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLHA_DAL
    {
        public byte[] ImageToByteArray(Image imageIn) // từ hình ảnh chuyển sang byte[] (lấy dữ liệu từ đường dẫn), lưu vô cơ sở dữ liệu
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public Image ConverByteToTmage(byte[] i)  // từ byte[] sang hình ảnh , lưu vô picturebox
        {
            Image newimage;
            if (i == null) { return null; }
            using (MemoryStream ms = new MemoryStream(i, 0, i.Length))
            {
                ms.Write(i, 0, i.Length);
                newimage = Image.FromStream(ms, true);
            }
            return newimage;
        }
    }
}
