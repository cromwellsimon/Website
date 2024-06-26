// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine.h"
#include "Engine/DataTable.h"
#include "Course.generated.h"

USTRUCT(BlueprintType)
struct WEBSITEUEMOCKUP_API FCourse : public FTableRowBase
{
	GENERATED_USTRUCT_BODY()

public:
	UPROPERTY(BlueprintReadWrite)
	FText Name;

	UPROPERTY(BlueprintReadWrite)
	FString Url;

	UPROPERTY(BlueprintReadWrite)
	FText Review;

	UPROPERTY(BlueprintReadWrite)
	FDateTime GeneralCompletionDate;

	UPROPERTY(BlueprintReadWrite)
	FString Notes;

	FCourse(){}
};