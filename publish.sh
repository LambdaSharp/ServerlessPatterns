#!/bin/bash
set -e
lash publish Bitcoin.Topic --module-origin serverlesspatterns --force-publish
lash publish Bitcoin.Table --module-origin serverlesspatterns --force-publish
lash publish Bitcoin.Event --module-origin serverlesspatterns --force-publish
