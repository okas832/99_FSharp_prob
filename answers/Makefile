exist_prob=$(filter-out Makefile, $(wildcard *))

all:
	$(foreach prob, $(exist_prob), $(MAKE) -C $(prob);)

clean:
	$(foreach prob, $(exist_prob), $(MAKE) -C $(prob) clean;)
