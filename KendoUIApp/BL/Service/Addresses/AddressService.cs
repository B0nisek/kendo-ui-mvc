using BL.Repository;
using AutoMapper;
using DAL.Entities;
using BL.Services;
using BL.DTO;
using System.Collections.Generic;

namespace BL.Service.Addresses
{
    public class AddressService : ServiceBase, IAddressService
    {
        private readonly AddressRepository addressRepository;

        public AddressService(AddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public void CreateAddress(AddressDTO addressDto)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                var address = Mapper.Map<Address>(addressDto);

                addressRepository.Insert(address);

                uow.Commit();
            }
        }

        public void DeleteAddress(int id)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                addressRepository.Delete(id);
                uow.Commit();
            }
        }

        public void EditAddress(AddressDTO addressDto)
        {
            using (var uow = UnitOfWorkProvider.Create())
            {
                var address = addressRepository.GetById(addressDto.Id);
                Mapper.Map(addressDto, address);

                addressRepository.Update(address);

                uow.Commit();
            }
        }

        public AddressDTO GetAddress(int id)
        {
            using (UnitOfWorkProvider.Create())
            {
                var address = addressRepository.GetById(id);
                return address != null ? Mapper.Map<AddressDTO>(address) : null;
            }
        }

        public IList<AddressDTO> GetAddressesById(int[] ids)
        {
            using (UnitOfWorkProvider.Create())
            {
                var addresses = addressRepository.GetByIds(ids);
                return Mapper.Map<IList<AddressDTO>>(addresses);
            }
        }
    }
}