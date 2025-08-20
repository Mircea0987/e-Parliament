using e_Parliament.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Parliament.Repository
{
    interface DocumentTypeRepository
    {
        public void addDocumentType(DocumentType documentType);
    }
}
