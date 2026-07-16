
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerlessListAppEventsCategoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        ConfigChanged,
        /// <summary>
        /// 
        /// </summary>
        DeploymentEnded,
        /// <summary>
        /// 
        /// </summary>
        DeploymentFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRecreateApplied,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingEnded,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingFailed,
        /// <summary>
        /// 
        /// </summary>
        DeploymentRollingStarted,
        /// <summary>
        /// 
        /// </summary>
        DeploymentStarted,
        /// <summary>
        /// 
        /// </summary>
        RunnerDockerPull,
        /// <summary>
        /// 
        /// </summary>
        RunnerDraining,
        /// <summary>
        /// 
        /// </summary>
        RunnerFailed,
        /// <summary>
        /// 
        /// </summary>
        RunnerFinished,
        /// <summary>
        /// 
        /// </summary>
        RunnerPending,
        /// <summary>
        /// 
        /// </summary>
        RunnerSetup,
        /// <summary>
        /// 
        /// </summary>
        RunnerStarted,
        /// <summary>
        /// 
        /// </summary>
        RunnerStartupFailure,
        /// <summary>
        /// 
        /// </summary>
        RunnerStopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListAppEventsCategoryItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsCategoryItem value)
        {
            return value switch
            {
                ServerlessListAppEventsCategoryItem.ConfigChanged => "config_changed",
                ServerlessListAppEventsCategoryItem.DeploymentEnded => "deployment_ended",
                ServerlessListAppEventsCategoryItem.DeploymentFailed => "deployment_failed",
                ServerlessListAppEventsCategoryItem.DeploymentRecreateApplied => "deployment_recreate_applied",
                ServerlessListAppEventsCategoryItem.DeploymentRollingEnded => "deployment_rolling_ended",
                ServerlessListAppEventsCategoryItem.DeploymentRollingFailed => "deployment_rolling_failed",
                ServerlessListAppEventsCategoryItem.DeploymentRollingStarted => "deployment_rolling_started",
                ServerlessListAppEventsCategoryItem.DeploymentStarted => "deployment_started",
                ServerlessListAppEventsCategoryItem.RunnerDockerPull => "runner_docker_pull",
                ServerlessListAppEventsCategoryItem.RunnerDraining => "runner_draining",
                ServerlessListAppEventsCategoryItem.RunnerFailed => "runner_failed",
                ServerlessListAppEventsCategoryItem.RunnerFinished => "runner_finished",
                ServerlessListAppEventsCategoryItem.RunnerPending => "runner_pending",
                ServerlessListAppEventsCategoryItem.RunnerSetup => "runner_setup",
                ServerlessListAppEventsCategoryItem.RunnerStarted => "runner_started",
                ServerlessListAppEventsCategoryItem.RunnerStartupFailure => "runner_startup_failure",
                ServerlessListAppEventsCategoryItem.RunnerStopping => "runner_stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsCategoryItem? ToEnum(string value)
        {
            return value switch
            {
                "config_changed" => ServerlessListAppEventsCategoryItem.ConfigChanged,
                "deployment_ended" => ServerlessListAppEventsCategoryItem.DeploymentEnded,
                "deployment_failed" => ServerlessListAppEventsCategoryItem.DeploymentFailed,
                "deployment_recreate_applied" => ServerlessListAppEventsCategoryItem.DeploymentRecreateApplied,
                "deployment_rolling_ended" => ServerlessListAppEventsCategoryItem.DeploymentRollingEnded,
                "deployment_rolling_failed" => ServerlessListAppEventsCategoryItem.DeploymentRollingFailed,
                "deployment_rolling_started" => ServerlessListAppEventsCategoryItem.DeploymentRollingStarted,
                "deployment_started" => ServerlessListAppEventsCategoryItem.DeploymentStarted,
                "runner_docker_pull" => ServerlessListAppEventsCategoryItem.RunnerDockerPull,
                "runner_draining" => ServerlessListAppEventsCategoryItem.RunnerDraining,
                "runner_failed" => ServerlessListAppEventsCategoryItem.RunnerFailed,
                "runner_finished" => ServerlessListAppEventsCategoryItem.RunnerFinished,
                "runner_pending" => ServerlessListAppEventsCategoryItem.RunnerPending,
                "runner_setup" => ServerlessListAppEventsCategoryItem.RunnerSetup,
                "runner_started" => ServerlessListAppEventsCategoryItem.RunnerStarted,
                "runner_startup_failure" => ServerlessListAppEventsCategoryItem.RunnerStartupFailure,
                "runner_stopping" => ServerlessListAppEventsCategoryItem.RunnerStopping,
                _ => null,
            };
        }
    }
}