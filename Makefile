DOTNET := $(shell which dotnet)

PRJ = main
BIN = $(PRJ).exe
SRC = $(PRJ).fs

ifneq (, $(DOTNET))
RUN = ./$(BIN)
else
FSC = fsharpc
RUN = mono ./$(BIN)
endif

all: $(BIN)

$(BIN): $(SRC)
ifneq (, $(DOTNET))
	dotnet build $(PRJ).fsproj
ifeq (,$(wildcard ./$(BIN)))
	@ln -s bin/Debug/net5.0/$(PRJ) $(BIN)
	@ln -s bin/Debug/net5.0/$(PRJ).dll .
	@ln -s bin/Debug/net5.0/FSharp.Core.dll .
endif
else
	$(FSC) --lib:. -r Expecto.dll --out:$(BIN) $(SRC) tests.fs
endif

clean:
ifneq (, $(DOTNET))
	@unlink $(PRJ).dll | true
	@unlink FSharp.Core.dll | true
	@rm -rf bin obj | true
endif
	rm -rf $(BIN) | true

.PHONY: all clean test

test: $(BIN)
	$(RUN)

p1: $(BIN)
	$(RUN) --filter-test-case p1

p2: $(BIN)
	$(RUN) --filter-test-case p2

p3: $(BIN)
	$(RUN) --filter-test-case p3

p4: $(BIN)
	$(RUN) --filter-test-case p4

p5: $(BIN)
	$(RUN) --filter-test-case p5

p6: $(BIN)
	$(RUN) --filter-test-case p6

p7: $(BIN)
	$(RUN) --filter-test-case p7

