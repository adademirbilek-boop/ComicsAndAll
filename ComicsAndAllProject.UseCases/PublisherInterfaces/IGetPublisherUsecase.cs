using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicsAndAllProject.Core.Entities;

namespace ComicsAndAllProject.UseCases.PublisherInterfaces
{
    public interface IGetPublisherUsecase
    {
        Publisher Execute(int id);
    }
}
