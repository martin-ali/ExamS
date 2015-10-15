﻿namespace ConsoleWebServer.Framework
{
    using System;
    using ConsoleWebServer.Framework.Interfaces;

    public abstract class Controller
    {
        protected Controller(HttpRequest request)
        {
            this.Request = request;
        }

        public HttpRequest Request { get; private set; }

        protected IResult GetResultContent(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        protected IResult GetResultJson(object model)
        {
            return new JsonResult(this.Request, model);
        }
    }
}