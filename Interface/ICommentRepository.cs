using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;

namespace api.Interface
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetComments();
    }
}