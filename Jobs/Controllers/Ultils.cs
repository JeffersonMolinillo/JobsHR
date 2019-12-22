using Microsoft.AspNetCore.Http;
using System.IO;

namespace Jobs.Controllers
{
    public static class Ultils
    {
        public static byte[] ToByteArray(this IFormFile file)
        {
            using (BinaryReader reader = new BinaryReader(file.OpenReadStream()))
            {
                return reader.ReadBytes((int)file.Length);
            }
        }


    }
}
