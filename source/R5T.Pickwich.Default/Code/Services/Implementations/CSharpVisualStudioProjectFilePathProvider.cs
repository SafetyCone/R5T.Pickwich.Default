using System;

using R5T.Lombardy;
using R5T.Pickwich.Types;


namespace R5T.Pickwich.Default
{
    public class CSharpVisualStudioProjectFilePathProvider : IVisualStudioProjectFilePathProvider
    {
        private IFileNameOperator FileNameOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public CSharpVisualStudioProjectFilePathProvider(IFileNameOperator fileNameOperator, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.FileNameOperator = fileNameOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetVisualStudioProjectFilePath(string projectDirectoryPath, string projectName)
        {
            var projectFileName = this.FileNameOperator.GetFileName(projectName, FileExtensions.CSharpProjectFileExtension);

            var projectFilePath = this.StringlyTypedPathOperator.GetFilePath(projectDirectoryPath, projectFileName);
            return projectFilePath;
        }
    }
}
