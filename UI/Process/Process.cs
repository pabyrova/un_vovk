using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using University.DataObjects;

namespace UI.Process
{
	public class Process:Entry
	{
		public virtual string Data
		{
			get
			{
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				return serializer.Serialize(_data);
			}
		}
		private ProcessDataObject _data;

		public Process()
		{
		}

		public Process(ProcessDataObject dataObject)
		{
			_data = dataObject;
		}

		public virtual IProcessControl GetView()
		{
			return null;
		}

		public bool Run()
		{
			using (ProcessForm form = new ProcessForm())
			{
				form.Data = _data;
				form.Control = GetView();
				if (form.ShowDialog() == DialogResult.Cancel)
					return false;
				ProcessSalaryDataObject processSalaryDataObject = _data as ProcessSalaryDataObject;
				if (processSalaryDataObject != null)
					processSalaryDataObject.FinalSalary = form.KostylFinalMoney;
				return true;
			}
		}
	}
}
