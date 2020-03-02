using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Camera;
using Ozeki.Media;
//using _01_Video_Camera_Viewer.LOG;
using System.IO;
using System.Runtime.Serialization;
namespace Camview
{
    public partial class View1 : Form
    {
        private IpCameraHandler _model;
        private String ConnectStr ;
        private readonly CameraURLBuilderWF _myCameraUrlBuilder;
        public View1(string Constr)
        {
            InitializeComponent();
            _myCameraUrlBuilder = new CameraURLBuilderWF();
            ConnectStr = Constr;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View1_Load(object sender, EventArgs e)
        {
            _model = new IpCameraHandler(0);
          //  _model.AvailableStreamsChanged += _model_AvailableStreamsChanged;
        //    _model.CameraStateChanged += ModelCameraStateChanged;
            _model.CameraErrorOccured += ModelCameraErrorOccured;
            videoViewerWF1.SetImageProvider(_model.ImageProvider);

            _model.ConnectOnvifCamera(ConnectStr);
            GetCameraStreams();
            System.Threading.Thread.Sleep(3000);
            var CurrentStream = _model.Camera.AvailableStreams[1];
            videoViewerWF1.Start();
        }
        private void GetCameraStreams()
        {
            if (_model.Camera.AvailableStreams.Any())
            {
                var selected = 0;
                InvokeGuiThread(() =>
                {
                    for (var index = 0; index < _model.Camera.AvailableStreams.Count; index++)
                    {
                        if (_model.Camera.CurrentStream.Name == _model.Camera.AvailableStreams[index].Name)
                        {
                            selected = index;
                        }
                        var name = _model.Camera.AvailableStreams[index].Name + " " + (_model.Camera.AvailableStreams[index].VideoEncoding != null ? _model.Camera.AvailableStreams[index].VideoEncoding.Resolution.ToString() : "_" + index);
                        //StreamCombo.Items.Add(name);
                    }
                   // StreamCombo.SelectedIndex = selected;
                });
            }
        }
        private void ModelCameraErrorOccured(object sender, CameraErrorEventArgs e)
        {
          //  InvokeGuiThread(() => Log.Write("Camera error: " + (e.Details ?? e.Error.ToString())));
        }
        private void InvokeGuiThread(Action action)
        {
            BeginInvoke(action);
        }
    }
}
