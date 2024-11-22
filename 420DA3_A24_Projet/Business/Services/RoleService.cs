using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;

namespace _420DA3_A24_Projet.Business.Services;
internal class RoleService {

    private readonly RoleDAO dao;

    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new RoleDAO(context);
    }
}
