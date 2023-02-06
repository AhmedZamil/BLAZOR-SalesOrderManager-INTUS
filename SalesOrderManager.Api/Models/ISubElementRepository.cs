﻿using SalesOrderManager.Shared.Domain;

namespace SalesOrderManager.Api.Models
{
    public interface ISubElementRepository
    {
        IEnumerable<SubElement> GetAllSubElements();
        IEnumerable<SubElement> GetAllSubElementsByWindowId(int windowId);
        SubElement GetSubElementById(int subElementId);
        SubElement AddSubElement(SubElement subElement);
        SubElement UpdateSubElement(SubElement subElement);
        void DeleteSubElement(int subElementId);
    }
}
