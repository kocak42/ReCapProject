using Core.Utilities.Result;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        IResult Upload(IFormFile file, string root);
        IResult Update(IFormFile file, string filePath, string root);
        IResult Delete(string filePath);
    }
}
