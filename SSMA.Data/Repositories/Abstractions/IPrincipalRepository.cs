﻿using SSMA.Models.Models;

namespace SSMA.Data.Repositories.Abstractions
{
    public interface IPrincipalRepository
    {
        public Task<Principal?> GetPrincipalAsync(string principalId);
        public Task<Principal?> GetPrincipalAsync();
        public Task<bool> AddPrincipal(Principal principal);
    }
}