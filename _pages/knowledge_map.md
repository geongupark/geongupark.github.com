---
title: "≫ Knowledge Map"
permalink: /knowledge_map/
layout: single
---
<br>
# <span style="color:#DF7401">Q. What is <u>knowledge map</u></span>?
- I make skeleton.


<div class="mermaid" style="font-size:2em">
flowchart TB;
	
	%% <!-- 1. Define Nodes -->
	gus([gus]);		%% Start node of Map

	%% S1 : Computer Science
	subgraph Computer Science;
		%% Layer 1
		S1_L1_N1(OS);	%% It means subgraph1, layer1, node1.

		%% Layer 2
		S1_L2_N1(Linux);	%% It means subgraph1, layer2, node1.
		S1_L2_N2(Windows);
		
		%% Layer 3
		S1_L3_N1(Linux kernel development);
		S1_L3_N2(Debugging for Linux kernel);
		S1_L3_N3(Windows system programming);
	end;
	
	%% S2 : AI
	subgraph AI;
		%% Layer 1
		S2_L1_N1(모두의 딥러닝);
		
	end;
	
	%% S3 : Language
	subgraph Language;
		%% Layer 1
		S3_L1_N1(Human);
		S3_L1_N2(Machine);
		
		%% Layer 2
		S3_L2_N1(English);
		S3_L2_N2(Markdown);
		
		%% Layer 3
		S3_L3_N1(365English);
	end;
	
	%% S4 : Book
	subgraph Book;
		%% Layer 1
		S4_L1_N1(Self-development);
		%%S4_L1_N2(Math/Science);
		%%S4_L1_N3(Fiction);
		%%S4_L1_N4(Economics);
	end;
	
	%% S5 : Paper
	subgraph Paper;
		%% Layer 1
		S5_L1_N1(Embedded system);
		S5_L1_N2(AI);
	end;
	
	%% <!-- 2. Define link : connecting Nodes -->
		%% <!-- gus to L1 -->
		gus---S1_L1_N1;
		
		gus---S2_L1_N1;
		
		gus---S3_L1_N1;
		gus---S3_L1_N2;
		
		gus---S4_L1_N1;
		%%gus---S4_L1_N2;
		%%gus---S4_L1_N3;
		%%gus---S4_L1_N4;
		
		gus---S5_L1_N1;
		gus---S5_L1_N2;
		
		%% <!-- L1 to L2 -->
		S1_L1_N1---S1_L2_N1;
		S1_L1_N1---S1_L2_N2;
		
		S3_L1_N1---S3_L2_N1;
		S3_L1_N2---S3_L2_N2;
		
		%% <!-- L2 to L3 -->
		S1_L2_N1---S1_L3_N1;
		S1_L2_N1---S1_L3_N2;
		S1_L2_N2---S1_L3_N3;
		
		S3_L2_N1---S3_L3_N1;
		
	
	%% <!-- 3. Configuration for style of nodes -->
	style gus fill:#F5A9F2,stroke:#333,stroke-width:4px
	
	%% <!-- 4. Event Handler -->
	click A callback "Tooltip"
	click B "http://www.github.com" "This is a link"
%%end;
</div>


