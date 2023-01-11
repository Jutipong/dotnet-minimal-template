using Web_Minimal.Features.Account.Dto;

namespace Web_Minimal.Features.Account.Service
{
    public interface IAccountService
    {
        public JsonResponse<Response.Create> Create(Request.CreateAccount create);
        public JsonResponse<Response.Update> Update(Request.UpdateAccount update);
        public JsonResponse<Response.Delete> Delete(Request.DeleteAccount delete);
    }
}
