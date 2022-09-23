using System;

namespace sanden_api.Helpers
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
