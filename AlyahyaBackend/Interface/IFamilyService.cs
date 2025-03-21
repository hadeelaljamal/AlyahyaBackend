using AlyahyaBackend.Models;

namespace AlyahyaBackend.Interface
{
    public interface IFamilyService
    {
        Task<IEnumerable<FamilyMember>> GetAllMembers();
        Task<FamilyMember> GetMemberById(int id);
        Task AddMember(FamilyMember member);
        Task UpdateMember(FamilyMember member);
        Task DeleteMember(int id);
    }
}
