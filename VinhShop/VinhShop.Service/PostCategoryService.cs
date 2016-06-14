﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinhShop.Data.Infrastructure;
using VinhShop.Data.Repositories;
using VinhShop.Model.Models;

namespace VinhShop.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parentId);
        PostCategory GetById(int id);
    }

    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public PostCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(PostCategory postCategory)
        {
            throw new NotImplementedException();
        }
    }
}
