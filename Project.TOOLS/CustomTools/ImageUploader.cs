using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Project.TOOLS.CustomTools
{
   public static class ImageUploader
    {
        public static string UploadImage(string serverPath, HttpPostedFileBase file)
        {
            if (file != null )
            {
                Guid uniqueName = Guid.NewGuid();
                
                serverPath = serverPath.Replace("~", string.Empty);

                string[] fileArray = file.FileName.Split('.');// dosya uzantısını yakalamak için . dan sonraki kısmı ayırmak için kullandık

                string extension = fileArray[fileArray.Length - 1].ToLower();// dosya uzantısını yakalayıp küçülttük

                string fileName = $"{uniqueName}{extension}";

                if (extension == "jpg" || extension=="gif"|| extension=="png"||extension=="jpeg"   )
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName)))
                    {
                        return "Dosya Zaten Var";
                    }
                    else
                    {
                        string filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);

                        file.SaveAs(filePath);
                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "Seçilen Dosya Bir Resim Değil..";
                }
            }
            else
            {
                return "Dosya Boş";
            }
        }
    }
}
