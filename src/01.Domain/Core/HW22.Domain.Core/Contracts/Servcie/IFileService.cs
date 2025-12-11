using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Servcie
{
    public interface IFileService
    {
        string Upload(IFormFile file, string folder);
        void Delete(string fileName);
    }
}
