﻿using api.Data;
using api.Dtos.Stock;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[Route("api/stock")]
[ApiController]


public class StockContoller : ControllerBase
{

    private readonly ApplicationDBContext _context;
    private readonly IStockRepository _stockRepo;
    public StockContoller(ApplicationDBContext context, IStockRepository stockRepo)
    {
        _stockRepo = stockRepo;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var Stocks = await  _stockRepo.GetAllAsync();
        var stockDto =  Stocks.Select(s => s.ToStockDto());
        return Ok(stockDto);

    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var stock = await _stockRepo.GetByIdAsync(id);
        if (stock == null)
        {
            return NotFound();
        }
        return Ok(stock.ToStockDto());


    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateStockRequestDto stockDto)
    {

        var stockModel = stockDto.ToStockFromCreateDTO();
        await _stockRepo.CreateAsync(stockModel);
        return CreatedAtAction(nameof(GetById), new { id = stockModel.Id }, stockModel.ToStockDto());
    }


    [HttpPut("{id}")]

    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStockRequestDto updateDto)
    {

        var stockModel = await _stockRepo.UpdateAsync(id , updateDto);

        if (stockModel == null)
        {
            return NotFound();
        }


        return Ok(stockModel.ToStockDto());
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var stockModel = await _stockRepo.DeleteAsync(id);

        if (stockModel == null)
        {
            return NotFound();
        }
        return NoContent();
    }

    



}
