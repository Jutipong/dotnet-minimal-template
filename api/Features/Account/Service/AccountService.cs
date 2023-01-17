using api.Features.Account.Dto;

namespace api.Features.Account.Service;

public class AccountService : IAccountService
{
    private readonly ILogger<AccountService> _log;

    public AccountService(ILogger<AccountService> log)
    {
        _log = log;
    }

    public JsonResponse<Response.Create>? Create(Request.CreateAccount create)
    {
        _log.LogInformation("============= start service {@Create} ===============", create);

        var result = new JsonResponse<Response.Create>
        {
            Datas = new Response.Create { Id = 99, Name = create.Name, Last = create.Last }
        };

        // //mack err
        // result.Datas = null;
        // var t = result.Datas.Id;

        _log.LogInformation("============= end service ===============");

        return result;
    }

    public JsonResponse<Response.Update> Update(Request.UpdateAccount update)
    {
        return new JsonResponse<Response.Update>
        {
            Datas = new Response.Update
            { Id = update.Id, Name = update.Name, Last = update.Last, DateTime = DateTime.Now }
        };
    }

    public JsonResponse<Response.Delete> Delete(Request.DeleteAccount delete)
    {
        return new JsonResponse<Response.Delete> { Datas = new Response.Delete { Id = delete.Id } };
    }
}