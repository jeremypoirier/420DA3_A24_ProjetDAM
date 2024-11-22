using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;

namespace _420DA3_A24_Projet.Business.Services;
internal class UserService {

    private readonly UserDAO dao;
    private readonly UserView view;

    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new UserDAO(context);
        this.view = new UserView(parentApp);
    }

    public User? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public User? GetByUsername(string username, bool includeDeleted = false) {
        return this.dao.GetByUsername(username, includeDeleted);
    }

    public List<User> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public User CreateNewUser(User user) {
        return this.dao.Create(user);
    }

    public User UpdateUser(User user) {
        return this.dao.Update(user);
    }

    public User DeleteUser(User user, bool softDeletes = true) {
        return this.dao.Delete(user, softDeletes);
    }

}
