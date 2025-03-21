using AlyahyaBackend.Interface;
using AlyahyaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class FamilyController : ControllerBase
{
    private readonly IFamilyService _service;

    public FamilyController(IFamilyService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FamilyMember>>> GetAll()
    {
        return Ok(await _service.GetAllMembers());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FamilyMember>> GetById(int id)
    {
        var member = await _service.GetMemberById(id);
        if (member == null) return NotFound();
        return Ok(member);
    }

    [HttpPost]
    public async Task<ActionResult> Create(FamilyMember member)
    {
        await _service.AddMember(member);
        return CreatedAtAction(nameof(GetById), new { id = member.Id }, member);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, FamilyMember member)
    {
        if (id != member.Id) return BadRequest();
        await _service.UpdateMember(member);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _service.DeleteMember(id);
        return NoContent();
    }
}
