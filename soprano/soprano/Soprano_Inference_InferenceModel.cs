//Auto-generated by kalyptus. DO NOT EDIT.
namespace Soprano.Inference {
	using Soprano;
	using System;
	using Qyoto;
	using System.Collections.Generic;
	/// <remarks>
	///  \class InferenceModel inferencemodel.h Soprano/Inference/InferenceModel
	///  \brief The Soprano Inference Model provides a simple forward chaining inference engine
	///  which uses the underlying parent model itself to store status information.
	///  The InferenceModel does perfect inference which means that removing of statements is supported
	///  and results in a perfect update of the infered statements. There is only one exception:
	///  If a model contains two statements in different named graphs that both have the same subject,
	///  predicate, and object and trigger one rule then if one of these statements is removed the
	///  infered statements are removed, too, although the second statement would still make the infered
	///  one valid. This situation gets resolved once the same rule is triggered again by some other
	///  added statement or performInference gets called.
	///  The inference is performed based on rules which are stored in Rule instances.
	///  Rules can be created manually or parsed using a RuleParser.
	///  <b>The inference engine works roughly as follows:</b>
	///  Whenever a new statement is added it is compared to each rule to check if it could trigger this rule.
	///  Then if it could trigger a rule this rule is applied to the whole model.
	///  If a rule produces a new infered statement the following data is created:
	///  <li>named</li> graph A containing the infered statements
	///  <li>the</li> statements that triggered the rule are stored in named graph sil:InferenceMetadata as
	///  source statements of A (sil:sourceStatement). The inference model supports two ways of storing
	///  source statements: plain and compressed (see setCompressedSourceStatements).
	///  Thus, when removing a statement it can easily be checked if this statement had been used to
	///  infer another one by querying all named graphs that have this statement as a source statement.
	///  \author Sebastian Trueg <trueg@kde.org>
	///          </remarks>		<short>    \class InferenceModel inferencemodel.</short>
	[SmokeClass("Soprano::Inference::InferenceModel")]
	public class InferenceModel : Soprano.FilterModel, IDisposable {
 		protected InferenceModel(Type dummy) : base((Type) null) {}
		protected new void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(InferenceModel), this);
		}
		public InferenceModel(Soprano.Model parent) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("InferenceModel#", "InferenceModel(Soprano::Model*)", typeof(void), typeof(Soprano.Model), parent);
		}
		/// <remarks>
		///  Add a new statement to the model. Inferencing will be done directly.
		///  Inferenced statements are stored in additional named graphs.
		///              </remarks>		<short>    Add a new statement to the model.</short>
		[SmokeMethod("addStatement(const Soprano::Statement&)")]
		public override Soprano.Error.ErrorCode AddStatement(Soprano.Statement arg1) {
			return (Soprano.Error.ErrorCode) interceptor.Invoke("addStatement#", "addStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), arg1);
		}
		/// <remarks>
		///  Remove one statement from the model.
		///              </remarks>		<short>    Remove one statement from the model.</short>
		[SmokeMethod("removeStatement(const Soprano::Statement&)")]
		public override Soprano.Error.ErrorCode RemoveStatement(Soprano.Statement arg1) {
			return (Soprano.Error.ErrorCode) interceptor.Invoke("removeStatement#", "removeStatement(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), arg1);
		}
		/// <remarks>
		///  Remove statements from the model.
		///              </remarks>		<short>    Remove statements from the model.</short>
		[SmokeMethod("removeAllStatements(const Soprano::Statement&)")]
		public override Soprano.Error.ErrorCode RemoveAllStatements(Soprano.Statement arg1) {
			return (Soprano.Error.ErrorCode) interceptor.Invoke("removeAllStatements#", "removeAllStatements(const Soprano::Statement&)", typeof(Soprano.Error.ErrorCode), typeof(Soprano.Statement), arg1);
		}
		/// <remarks>
		///  Add an inference rule to the set of rules.
		///  This method will not trigger any inference action. If inference
		///  is necessary call performInference() after adding the new rules.
		///              </remarks>		<short>    Add an inference rule to the set of rules.</short>
		public void AddRule(Soprano.Inference.Rule arg1) {
			interceptor.Invoke("addRule#", "addRule(const Soprano::Inference::Rule&)", typeof(void), typeof(Soprano.Inference.Rule), arg1);
		}
		/// <remarks>
		///  Set the inference rules to be used.
		///  This method will not trigger any inference action. If inference
		///  is necessary call performInference() after adding the new rules.
		///              </remarks>		<short>    Set the inference rules to be used.</short>
		public void SetRules(List<Soprano.Inference.Rule> rules) {
			interceptor.Invoke("setRules?", "setRules(const QList<Soprano::Inference::Rule>&)", typeof(void), typeof(List<Soprano.Inference.Rule>), rules);
		}
		/// <remarks>
		///  Normally inferencing is done one new statements are added to the model or
		///  statements are removed. This method performs inferencing on the whole model.
		///  It is useful for initializing a model that already contains statements or
		///  update the model if it has been modified bypassing this filter model.
		///  Tha latter can easily be done by connecting the Model.StatementsAdded and 
		///  Model.StatementsRemoved signals to this slot.
		///              </remarks>		<short>    Normally inferencing is done one new statements are added to the model or  statements are removed.</short>
		[Q_SLOT("void performInference()")]
		public void PerformInference() {
			interceptor.Invoke("performInference", "performInference()", typeof(void));
		}
		/// <remarks>
		///  Removes all statements infered by this model.
		///  This can be useful if the parent model has been changed without informing
		///  the inference model and statements have been removed.
		///              </remarks>		<short>    Removes all statements infered by this model.</short>
		[Q_SLOT("void clearInference()")]
		public void ClearInference() {
			interceptor.Invoke("clearInference", "clearInference()", typeof(void));
		}
		/// <remarks>
		///  If compressed statements are enabled source statements are stored compressed
		///  in one literal value. Otherwise source statements are stored using rdf:subject,
		///  rdf:predicate, rdf:object, and sil:context. Non-compressed statements are much
		///  cleaner from an ontology design point of view while compressed statements take
		///  much less space.
		///  By default comressed source statements are enabled.
		///  This method exists mainly for historical reasons and there normally is no need
		///  to call it. Compressed statements should work well for most users.
		///  \param b If true compressed source statements are enabled (the default).
		///              </remarks>		<short>    If compressed statements are enabled source statements are stored compressed  in one literal value.</short>
		[Q_SLOT("void setCompressedSourceStatements(bool)")]
		public void SetCompressedSourceStatements(bool b) {
			interceptor.Invoke("setCompressedSourceStatements$", "setCompressedSourceStatements(bool)", typeof(void), typeof(bool), b);
		}
		/// <remarks>
		///  If the storage backend supports joined SPARQL queries via UNION
		///  it makes sense to enable this.
		///  \param b If true InferenceModel will use optimized queries for
		///  the inference during addStatement. This will speed up the 
		///  process quite a lot as matching rules are only applied to the new statement.
		///  This flag has no influcence on performInference() though.
		///  The default is to disable the optimized queries since the default
		///  soprano redland backend does not support UNION.
		///              </remarks>		<short>    If the storage backend supports joined SPARQL queries via UNION  it makes sense to enable this.</short>
		[Q_SLOT("void setOptimizedQueriesEnabled(bool)")]
		public void SetOptimizedQueriesEnabled(bool b) {
			interceptor.Invoke("setOptimizedQueriesEnabled$", "setOptimizedQueriesEnabled(bool)", typeof(void), typeof(bool), b);
		}
		~InferenceModel() {
			interceptor.Invoke("~InferenceModel", "~InferenceModel()", typeof(void));
		}
		public new void Dispose() {
			interceptor.Invoke("~InferenceModel", "~InferenceModel()", typeof(void));
		}
		protected new IInferenceModelSignals Emit {
			get { return (IInferenceModelSignals) Q_EMIT; }
		}
	}

	public interface IInferenceModelSignals : Soprano.IFilterModelSignals {
	}
}
