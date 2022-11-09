using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppEF_CodeFirst.IRepository;
using WebAppEF_CodeFirst.Models;

namespace WebAppEF_CodeFirst.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private BatchDbContext _context;
        public CourseRepository(BatchDbContext context)
        {
            _context = context;
        }
        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        //public void DeleteBatch(int id)
        //{
        //    Batch obj = Search(id);
        //    _context.Batches.Remove(obj);
        //    _context.SaveChanges();
        //}

        //public void EditBatch(int id, Batch batch)
        //{
        //    Batch obj = Search(id);
        //    if(obj!=null)
        //    {
        //        foreach(Batch temp in _context.Batches)
        //        {
        //            if(temp.Id == id)
        //            {
        //                temp.Name = batch.Name;
        //                temp.StartDate = batch.StartDate;
        //                temp.Trainer = batch.Trainer; 
        //            }
                   
        //        }
        //        _context.SaveChanges();
        //    }
        //}

        //public Batch Search(int id)
        //{
        //    Batch batch = _context.Batches.FirstOrDefault(x => x.Id == id);
        //    return batch;
        //}

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }
    }
}
