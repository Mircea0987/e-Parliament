using e_Parliament.DbContextApp;
using e_Parliament.models;
using e_Parliament.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.Services
{
    internal class DocumentTypeService : DocumentTypeRepository
    {
        private AppDbContext _context;
        public void addDocumentType(DocumentType documentType)
        {
            if(documentType == null)
            {
                throw new Exception("Document type cannot be null");
            }
            else
            {
                using (_context = new AppDbContext())
                {
                    _context.document_types.AddAsync(documentType);
                    _context.SaveChanges();
                }
            }
        }
    }
}
