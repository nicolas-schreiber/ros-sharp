/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PoseWithCovariance : Message
    {
        public override string RosMessageName => "geometry_msgs/PoseWithCovariance";

        //  This represents a pose in free space with uncertainty.
        public Pose pose { get; set; }
        //  Row-major representation of the 6x6 covariance matrix
        //  The orientation parameters use a fixed-axis representation.
        //  In order, the parameters are:
        //  (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
        public double[] covariance { get; set; }

        public PoseWithCovariance()
        {
            this.pose = new Pose();
            this.covariance = new double[36];
        }

        public PoseWithCovariance(Pose pose, double[] covariance)
        {
            this.pose = pose;
            this.covariance = covariance;
        }
    }
}
