using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF: documenter
/// </summary>
internal class RoleService {

    private readonly RoleDAO dao;
    private readonly RoleView view;

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <returns></returns>
    public Role? OpenUserWindowForCreation() {
        Role newRole = (Role) FormatterServices.GetUninitializedObject(typeof(Role));
        DialogResult result = this.view.OpenForCreation(newRole);
        return result == DialogResult.OK ? newRole : null;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role? OpenUserWindowForDetailsView(Role role) {
        DialogResult result = this.view.OpenForDetailsView(role);
        return result == DialogResult.OK ? role : null;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role? OpenUserWindowForEdition(Role role) {
        DialogResult result = this.view.OpenForEdition(role);
        return result == DialogResult.OK ? role : null;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role? OpenUserWindowForDeletion(Role role) {
        DialogResult result = this.view.OpenForDeletion(role);
        return result == DialogResult.OK ? role : null;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAll(bool includeDeleted = false) {
        return this.dao.GetAll(includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByRoleName(string roleName, bool includeDeleted = false) {
        return this.dao.GetByRoleName(roleName, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Create(Role role) {
        return this.dao.Create(role);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role Update(Role role) {
        return this.dao.Update(role);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role Delete(Role role, bool softDeletes = true) {
        return this.dao.Delete(role, softDeletes);
    }

}
