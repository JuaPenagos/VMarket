using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace VMarket.Classes
{
    public class FileHelper
    {
        public static bool UploadPhoto(HttpPostedFileBase file, string folder, String name)
        {
            if (file == null|| String.IsNullOrEmpty(folder)|| String.IsNullOrEmpty(name))
            {
                return false;
            }

           
            try
            {
                string path = string.Empty;

                if (file != null)
                {
                    
                    path = Path.Combine(HttpContext.Current.Server.MapPath(folder), name);
                    file.SaveAs(path);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        file.InputStream.CopyTo(ms);
                        byte[] array = ms.GetBuffer();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
                return false;
            }
        }
    }
}