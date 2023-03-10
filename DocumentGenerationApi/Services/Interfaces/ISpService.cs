﻿using DocumentGenerationApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerationApi.Services.Interfaces
{
    public interface ISpService
    {
        public Task<IActionResult> ExecuteStoreProcedure(SpRequestModel requestModel);
    }
}
