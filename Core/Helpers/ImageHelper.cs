using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Core.Helpers
{
    public class ImageHelper :IHelper
    {
        public  IDataResult<string> CopyImageToFile(IFormFileCollection filess)
        {
            var newFileName = string.Empty;
            var fileName = string.Empty;
            string PathDB = string.Empty;

            if (filess != null)
            {
                var files = filess;

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        //Getting FileName
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                        //Getting file Extension
                        var FileExtension = Path.GetExtension(fileName);

                        // concating  FileName + FileExtension
                        newFileName = myUniqueFileName + FileExtension;

                        // Combines two strings into a path.
                        fileName = Path.Combine("C:\\Users\\Fahrican\\source\\repos\\ArabaKiralamaRecap\\ArabaKiralama\\WebAPI\\wwwroot", "demoImages") + $@"\{newFileName}";

                        // if you want to store path of folder in database
                        PathDB = "demoImages/" + newFileName;

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            return new SuccesDataResult<string>(PathDB, "Başarı ile resim eklendi");
        }

        public IResult Delete(string imagePath)
        {
            var path = Path.Combine("C:\\Users\\Fahrican\\source\\repos\\ArabaKiralamaRecap\\ArabaKiralama\\WebAPI\\wwwroot", "demoImages") + $@"\{imagePath}";
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return new SuccesResutl("Silindi.");
            }
            else
            {
                return new ErrorResult("Silinemedi.");
            }
            
        }

        public IDataResult<string> Update(IFormFileCollection filess , string imagePath)
        {

            var resultDelete = Delete(imagePath);
            if (resultDelete.Succes)
            {
                var resultCopyImage = CopyImageToFile(filess);
                return new SuccesDataResult<string>(resultCopyImage.Message);
            }
            else
            {
                return new ErrorDataResult<string>("Başaramdık abi upload patladı");
            }                     
        }

        
    }
}
