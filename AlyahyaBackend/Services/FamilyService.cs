using AlyahyaBackend.Interface;
using AlyahyaBackend.Models;

namespace AlyahyaBackend.Services
{
    public class FamilyService:IFamilyService
    {
        private readonly IFamilyRepository _repository;

        public FamilyService(IFamilyRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FamilyMember>> GetAllMembers()
        {
            return await _repository.GetAllMembers();
        }

        public async Task<FamilyMember> GetMemberById(int id)
        {
            return await _repository.GetMemberById(id);
        }

        public async Task AddMember(FamilyMember member)
        {
            await _repository.AddMember(member);
        }

        public async Task UpdateMember(FamilyMember member)
        {
            await _repository.UpdateMember(member);
        }

        public async Task DeleteMember(int id)
        {
            await _repository.DeleteMember(id);
        }
    }
}
