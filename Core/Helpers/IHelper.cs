using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Core.Helpers
{
    public interface IHelper
    {
        IDataResult<string> CopyImageToFile(IFormFileCollection filess);
        IResult Delete(string imagePath);
        IDataResult<string> Update(IFormFileCollection filess, string imagePath);
    }
}
