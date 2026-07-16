
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerlessListAppEventsCategory2
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
    public static class ServerlessListAppEventsCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsCategory2 value)
        {
            return value switch
            {
                ServerlessListAppEventsCategory2.ConfigChanged => "config_changed",
                ServerlessListAppEventsCategory2.DeploymentEnded => "deployment_ended",
                ServerlessListAppEventsCategory2.DeploymentFailed => "deployment_failed",
                ServerlessListAppEventsCategory2.DeploymentRecreateApplied => "deployment_recreate_applied",
                ServerlessListAppEventsCategory2.DeploymentRollingEnded => "deployment_rolling_ended",
                ServerlessListAppEventsCategory2.DeploymentRollingFailed => "deployment_rolling_failed",
                ServerlessListAppEventsCategory2.DeploymentRollingStarted => "deployment_rolling_started",
                ServerlessListAppEventsCategory2.DeploymentStarted => "deployment_started",
                ServerlessListAppEventsCategory2.RunnerDockerPull => "runner_docker_pull",
                ServerlessListAppEventsCategory2.RunnerDraining => "runner_draining",
                ServerlessListAppEventsCategory2.RunnerFailed => "runner_failed",
                ServerlessListAppEventsCategory2.RunnerFinished => "runner_finished",
                ServerlessListAppEventsCategory2.RunnerPending => "runner_pending",
                ServerlessListAppEventsCategory2.RunnerSetup => "runner_setup",
                ServerlessListAppEventsCategory2.RunnerStarted => "runner_started",
                ServerlessListAppEventsCategory2.RunnerStartupFailure => "runner_startup_failure",
                ServerlessListAppEventsCategory2.RunnerStopping => "runner_stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsCategory2? ToEnum(string value)
        {
            return value switch
            {
                "config_changed" => ServerlessListAppEventsCategory2.ConfigChanged,
                "deployment_ended" => ServerlessListAppEventsCategory2.DeploymentEnded,
                "deployment_failed" => ServerlessListAppEventsCategory2.DeploymentFailed,
                "deployment_recreate_applied" => ServerlessListAppEventsCategory2.DeploymentRecreateApplied,
                "deployment_rolling_ended" => ServerlessListAppEventsCategory2.DeploymentRollingEnded,
                "deployment_rolling_failed" => ServerlessListAppEventsCategory2.DeploymentRollingFailed,
                "deployment_rolling_started" => ServerlessListAppEventsCategory2.DeploymentRollingStarted,
                "deployment_started" => ServerlessListAppEventsCategory2.DeploymentStarted,
                "runner_docker_pull" => ServerlessListAppEventsCategory2.RunnerDockerPull,
                "runner_draining" => ServerlessListAppEventsCategory2.RunnerDraining,
                "runner_failed" => ServerlessListAppEventsCategory2.RunnerFailed,
                "runner_finished" => ServerlessListAppEventsCategory2.RunnerFinished,
                "runner_pending" => ServerlessListAppEventsCategory2.RunnerPending,
                "runner_setup" => ServerlessListAppEventsCategory2.RunnerSetup,
                "runner_started" => ServerlessListAppEventsCategory2.RunnerStarted,
                "runner_startup_failure" => ServerlessListAppEventsCategory2.RunnerStartupFailure,
                "runner_stopping" => ServerlessListAppEventsCategory2.RunnerStopping,
                _ => null,
            };
        }
    }
}