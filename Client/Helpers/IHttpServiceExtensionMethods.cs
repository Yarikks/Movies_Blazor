﻿using Movies_Blazor.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_Blazor.Client.Helpers
{
    public static class IHttpServiceExtensionMethods
    {
        public static async Task<T> GetHelper<T>(this IHttpService httpService, string url)
        {
            var response = await httpService.Get<T>(url);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public static async Task<PaginatedResponse<T>> GetHelper<T>(this IHttpService httpService, string url, PaginationDTO paginationDTO)
        {
            string newURL = "";

            if (url.Contains("?"))
            {
                newURL = $"{url}&page={paginationDTO.Page}&recordsPerPage={paginationDTO.RecordrsPerPage}";
            }
            else
            {
                newURL = $"{url}&page={paginationDTO.Page}&recordsPerPage={paginationDTO.RecordrsPerPage}";

            }

            var httpResponse = await httpService.Get<T>(url);
            var totalAmountPages = int.Parse(httpResponse.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<T>
            {
                Response = httpResponse.Response,
                TotalAmountPages = totalAmountPages
            };

            return paginatedResponse;
        }
    }
}
