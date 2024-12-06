﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2024 PICO Developer
// SPDX-License-Identifier: MIT
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections;

namespace behaviac
{

	public class BehaviorLoaderImplement : BehaviorLoader
	{
		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 4086522957;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(24743406);
			AgentMeta._AgentMetas_[2436498804] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// PicoMRDemo.Runtime.Pet.PetAgent
			meta = new AgentMeta(1258109957);
			AgentMeta._AgentMetas_[2009524875] = meta;
			meta.RegisterMethod(4113135372, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).CheckCatchBall(); }));
			meta.RegisterMethod(3314117865, new CAgentMethod<float>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).GetRandomValue(); }));
			meta.RegisterMethod(2184363993, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).HasInVirtualWorld(); }));
			meta.RegisterMethod(3989009733, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).IsCatchingBall(); }));
			meta.RegisterMethod(3886701596, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).IsRua(); }));
			meta.RegisterMethod(3636643904, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).IsTouch(); }));
			meta.RegisterMethod(3247142779, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).IsVirtualWorld(); }));
			meta.RegisterMethod(1528302711, new CAgentMethod<bool>(delegate(Agent self) { return ((PicoMRDemo.Runtime.Pet.PetAgent)self).IsWalkFinish(); }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { PicoMRDemo.Runtime.Pet.PetAgent.LogMessage(param0); }));
			meta.RegisterMethod(740963922, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).Patrol(); }));
			meta.RegisterMethod(3027631725, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).PlayCatchBall(); }));
			meta.RegisterMethod(1530362739, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).PlayIdle(); }));
			meta.RegisterMethod(1698367831, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).PlayRua(); }));
			meta.RegisterMethod(767201068, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).PlayWalk(); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());
			meta.RegisterMethod(2384217948, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).WalkToRealWorld(); }));
			meta.RegisterMethod(3052411395, new CAgentMethodVoid(delegate(Agent self) { ((PicoMRDemo.Runtime.Pet.PetAgent)self).WalkToVirtualWorld(); }));

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<PicoMRDemo.Runtime.Pet.PetAgent>("PicoMRDemo.Runtime.Pet.PetAgent");
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<PicoMRDemo.Runtime.Pet.PetAgent>("PicoMRDemo.Runtime.Pet.PetAgent");
			return true;
		}
	}
}
