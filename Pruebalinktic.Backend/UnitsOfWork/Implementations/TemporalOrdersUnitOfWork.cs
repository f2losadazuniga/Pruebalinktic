﻿using Pruebalinktic.Backend.Repositories.Interfaces;
using Pruebalinktic.Backend.UnitsOfWork.Interfaces;
using Pruebalinktic.Shared.DTOs;
using Pruebalinktic.Shared.Entities;
using Pruebalinktic.Shared.Responses;

namespace Pruebalinktic.Backend.UnitsOfWork.Implementations
{
    public class TemporalOrdersUnitOfWork : GenericUnitOfWork<TemporalOrder>, ITemporalOrdersUnitOfWork
    {
        private readonly ITemporalOrdersRepository _temporalOrdersRepository;

        public TemporalOrdersUnitOfWork(IGenericRepository<TemporalOrder> repository, ITemporalOrdersRepository temporalOrdersRepository) : base(repository)
        {
            _temporalOrdersRepository = temporalOrdersRepository;
        }

        public async Task<ActionResponse<TemporalOrder>> PutFullAsync(TemporalOrderDTO temporalOrderDTO) => await _temporalOrdersRepository.PutFullAsync(temporalOrderDTO);

        public override async Task<ActionResponse<TemporalOrder>> GetAsync(int id) => await _temporalOrdersRepository.GetAsync(id);

        public async Task<ActionResponse<TemporalOrderDTO>> AddFullAsync(string email, TemporalOrderDTO temporalOrderDTO) => await _temporalOrdersRepository.AddFullAsync(email, temporalOrderDTO);

        public async Task<ActionResponse<IEnumerable<TemporalOrder>>> GetAsync(string email) => await _temporalOrdersRepository.GetAsync(email);

        public async Task<ActionResponse<int>> GetCountAsync(string email) => await _temporalOrdersRepository.GetCountAsync(email);
    }
}