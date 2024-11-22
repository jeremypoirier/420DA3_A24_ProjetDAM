using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private WsysDbContext context;
    public PasswordService PasswordService { get; private set; }
    public TrackingNumberFactory TrackingNumberFactory { get; private set; }
    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }

    public WsysApplication() {
        this.context = new WsysDbContext();
        this.PasswordService = PasswordService.GetInstance();
        this.TrackingNumberFactory = TrackingNumberFactory.GetInstance();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
    }

}
