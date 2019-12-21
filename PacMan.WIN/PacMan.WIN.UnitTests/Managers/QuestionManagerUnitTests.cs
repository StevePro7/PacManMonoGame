using System;
using NUnit.Framework;
using WindowsGame.Common.Managers;
using WindowsGame.Common.Objects;

namespace WindowsGame.UnitTests.Managers
{
	[TestFixture]
	public class QuestionManagerUnitTests : BaseUnitTests
	{
		[SetUp]
		public new void SetUp()
		{
			QuestionManager = new QuestionManager();
		}

		[Test]
		public void LoadQuestionDataTest()
		{
			// Arrange.
			String line = String.Empty;

			// Act.
			Question question = QuestionManager.LoadQuestion(line);

			// Assert.
			Assert.That(question, Is.Not.Null);
		}

		[TearDown]
		public void TearDown()
		{
			QuestionManager = null;
		}

	}
}