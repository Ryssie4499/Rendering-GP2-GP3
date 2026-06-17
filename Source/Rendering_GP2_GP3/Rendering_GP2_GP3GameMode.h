// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "Rendering_GP2_GP3GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class ARendering_GP2_GP3GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	ARendering_GP2_GP3GameMode();
};



