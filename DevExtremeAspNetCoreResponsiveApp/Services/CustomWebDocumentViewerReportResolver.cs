using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Services
{
    public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver
    {

        public XtraReport Resolve(string reportEntry)
        {
            if (reportEntry.StartsWith("PlandePago"))
            {
                XtraReport rep = CreateReport(reportEntry);
                rep.DataSource = CreateObjectDataSource(reportEntry);
                return rep;
            }
            return new XtraReport();
        }

        private object CreateObjectDataSource(string reportName)
        {
            ObjectDataSource dataSource = new ObjectDataSource();
            dataSource.Name = "";
            dataSource.DataSource = typeof(Asignacion_PlandePago);
            dataSource.DataMember = "PlandePago";
            
            return dataSource;
            /*if (reportName == "EmployeeReport")
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                dataSource.Constructor = ObjectConstructorInfo.Default;
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            if (reportName.EndsWith("7"))
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                // Specify the parameter's default value.
                var parameter = new Parameter("noOfItems", typeof(int), 7);
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            if (reportName.EndsWith("Parameter"))
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                // Map data source parameter to report's parameter.
                var parameter = new Parameter()
                {
                    Name = "noOfItems",
                    Type = typeof(DevExpress.DataAccess.Expression),
                    Value = new DevExpress.DataAccess.Expression("?parameterNoOfItems", typeof(int))
                };
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeList);
                var parameterNoOfItems = new Parameter("noOfItems", typeof(int), 12);
                dataSource.Parameters.Add(parameterNoOfItems);
                dataSource.Constructor = ObjectConstructorInfo.Default;
                dataSource.DataMember = "GetData";
                return dataSource;
            }*/
        }

        private XtraReport CreateReport(string reportEntry)
        {
            //if (reportEntry.Contains("Parameter"))
            //{
            //    XtraReport report = new PredefinedReports.EmployeeReport();
            //    DevExpress.XtraReports.Parameters.Parameter param =
            //        new DevExpress.XtraReports.Parameters.Parameter()
            //        {
            //            Name = "parameterNoOfItems",
            //            Type = typeof(int),
            //            Value = 5
            //        };
            //    param.Description = "Number of Items";
            //    report.Parameters.Add(param);
            //    report.RequestParameters = false;
            //    return report;
            //}
            //else
                return new Reports.PlandePago();
        }

    }
}
