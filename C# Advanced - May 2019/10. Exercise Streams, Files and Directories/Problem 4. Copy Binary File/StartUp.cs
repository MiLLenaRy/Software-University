using System;using System.Collections.Generic;using System.IO;using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace Problem_4._Copy_Binary_File
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (var reader = new FileStream(picPath, FileMode.Open))
            {
                using(var writer=new FileStream(picCopyPath,FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];
                        var size = reader.Read(byteArray, 0, byteArray.Length);
                        writer.Write(byteArray, 0, size);
                        if (size==0)
                        {
                            break; 
                        }
                    }
                }
            }
        }
    }
}
