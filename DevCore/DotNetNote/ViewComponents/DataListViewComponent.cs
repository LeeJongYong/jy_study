﻿using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetNote.ViewComponents
{
    public class DataListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var data = await GetByNameAsync(name);
            return View(data);
        }

        private Task<IEnumerable<Models.Data>> GetByNameAsync(string name)
        {
            return Task.FromResult(GetByName(name));
        }

        private IEnumerable<Models.Data> GetByName(string name)
        {
            DataService service = new DataService();
            return service.GetDataByName(name);
        }
    }
}
