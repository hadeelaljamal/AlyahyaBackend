using AlyahyaBackend.Interface;
using AlyahyaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AlyahyaBackend.Repositories
{
    public class FamilyRepository:IFamilyRepository
    {
        private readonly ApplicationDbContext _context;

        public FamilyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FamilyMember>> GetAllMembers()
        {
            return await _context.FamilyMembers.ToListAsync();
        }

        public async Task<FamilyMember> GetMemberById(int id)
        {
            return await _context.FamilyMembers.FindAsync(id);
        }

        public async Task AddMember(FamilyMember member)
        {
            _context.FamilyMembers.Add(member);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMember(FamilyMember member)
        {
            _context.FamilyMembers.Update(member);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMember(int id)
        {
            var member = await _context.FamilyMembers.FindAsync(id);
            if (member != null)
            {
                _context.FamilyMembers.Remove(member);
                await _context.SaveChangesAsync();
            }
        }
    }
}
