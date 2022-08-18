﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_App.Data.IRepositories;
using WPF_App.Domain.Entities.Attachments;

namespace WPF_App.Data.Repositories
{
    public class AttachmentRepository: GenericRepository<Attachment>, IAttachmentRepository
    {
        
    }
}
